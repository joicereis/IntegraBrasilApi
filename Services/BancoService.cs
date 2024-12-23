﻿using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos()
        {
            var bancos = await _brasilApi.BuscaTodosOsBancos();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscaBancoPorCodigo(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
        }
    }
}
