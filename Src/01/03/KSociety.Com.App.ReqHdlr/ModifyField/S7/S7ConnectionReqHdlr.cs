﻿using System;
using System.Threading;
using System.Threading.Tasks;
using KSociety.Base.App.Shared;
using KSociety.Base.Infra.Shared.Interface;
using KSociety.Com.App.Dto.Req.ModifyField.S7;
using KSociety.Com.Domain.Repository.S7;
using Microsoft.Extensions.Logging;

namespace KSociety.Com.App.ReqHdlr.ModifyField.S7
{
    public class S7ConnectionReqHdlr :
        IRequestHandlerWithResponse<S7Connection, KSociety.Com.App.Dto.Res.ModifyField.S7.S7Connection>,
        IRequestHandlerWithResponseAsync<S7Connection, KSociety.Com.App.Dto.Res.ModifyField.S7.S7Connection>
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger<S7ConnectionReqHdlr> _logger;
        private readonly IDbUnitOfWork _unitOfWork;
        private readonly IConnection _connectionRepository;

        public S7ConnectionReqHdlr(ILoggerFactory loggerFactory, IDbUnitOfWork unitOfWork, IConnection connectionRepository)
        {
            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.CreateLogger<S7ConnectionReqHdlr>();
            _unitOfWork = unitOfWork;
            _connectionRepository = connectionRepository;
        }

        public KSociety.Com.App.Dto.Res.ModifyField.S7.S7Connection Execute(S7Connection request)
        {
            var s7Connection = _connectionRepository.Find(request.Id); //.GetAllS7Connection().SingleOrDefault(g => g.Id == request.Id);

            s7Connection?.ModifyField(request.FieldName, request.Value);

            var result = _unitOfWork.Commit();

            return new KSociety.Com.App.Dto.Res.ModifyField.S7.S7Connection(result > 0);
        }

        public async ValueTask<KSociety.Com.App.Dto.Res.ModifyField.S7.S7Connection> ExecuteAsync(S7Connection request, CancellationToken cancellationToken = default)
        {
            var s7Connection = await _connectionRepository.FindAsync(cancellationToken, request.Id).ConfigureAwait(false); //.GetAllS7Connection().SingleOrDefault(g => g.Id == request.Id);
            try
            {
                s7Connection?.ModifyField(request.FieldName, request.Value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + " - " + ex.StackTrace);
            }

            var result = await _unitOfWork.CommitAsync(cancellationToken).ConfigureAwait(false);

            return new KSociety.Com.App.Dto.Res.ModifyField.S7.S7Connection(result > 0);
        }
    }
}
