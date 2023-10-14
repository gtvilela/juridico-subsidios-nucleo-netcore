using Juridico.Subsidios.Nucleo.Domain.Models.DocumentoModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Subsidios.Nucleo.Domain.Mocks
{
    public static class DocumentoMock
    {
        public const string RETORNO_CRLV = @"{
                                            ""identificadorArquivo"": ""a9b918b4-6ad9-11ee-b962-0242ac120002"",
                                            ""nomeArquivo"":""a9b918b4-6ad9-11ee-b962-0242ac120002.pdf"",
                                            ""dataCriacaoArquivo"":""09/09/2023 00:00:00"",
                                            ""linkArquivo"":""https://ged.locadora.com/CRLV/a9b918b4-6ad9-11ee-b962-0242ac120002.pdf"",
                                            ""arquivo"":""UKOvDN+0F2VB/0Uw3d73GXK+iEe55cfp83EOqt2WadT4+EicCE4AGqXtlt7SyX54ID1StP5Oa9qdsitGaryl9rICMw8BHPcTNNUtjWqzYJ/evU7EshEdy5sBeWCY3sYnVCVx9w=="",
                                            ""tamanhoArquivo"":""1,79 MB"",
                                            ""codigoCliente"":""000122276"",
                                            ""metadados"":
                                            [
                                                {
                                                    ""nome"":""SiglaDocumento"",
                                                    ""operador"":"""",
                                                    ""valor"":""CRLV""
                                                },
                                                {
                                                    ""nome"":""Placa"",
                                                    ""operador"":"""",
                                                    ""valor"":""OMG0248""
                                                }
                                            ]
   
                                        }";


        public const string RETORNO_BO = @"{
                                            ""identificadorArquivo"": ""b2389f44-6adb-11ee-b962-0242ac120002"",
                                            ""nomeArquivo"":""ab2389f44-6adb-11ee-b962-0242ac120002.pdf"",
                                            ""dataCriacaoArquivo"":""09/09/2023 00:00:00"",
                                            ""linkArquivo"":""https://ged.locadora.com/BO/b2389f44-6adb-11ee-b962-0242ac120002.pdf"",
                                            ""arquivo"":""fvm2bYH4RgcCUxDNAMvkqds5/wVyDnlBHxUSJxAtWY9uYrCDNlitTtfObWX3nEA64Sg5QJ3LzlThBIawv0RMKjXKVmFX0qjjT9fD7tWDm + o5jVLJ1OoeNNMeRL0Fqo2QdM8DmQ == "",
                                            ""tamanhoArquivo"":""1,79 MB"",
                                            ""codigoCliente"":""000122276"",
                                            ""metadados"":
                                            [
                                                {
                                                ""nome"":""SiglaDocumento"",
                                                    ""operador"":"""",
                                                    ""valor"":""BO""
                                                },
                                                {
                                                ""nome"":""CodigoSinistro"",
                                                    ""operador"":"""",
                                                    ""valor"":""099876540""
                                                },
                                                {
                                                ""nome"":""Placa"",
                                                    ""operador"":"""",
                                                    ""valor"":""OMG0248""
                                                }
                                            ]
   
                                        }";

        public const string RETORNO_CTT = @"{
                                            ""identificadorArquivo"": ""f7500982-6adb-11ee-b962-0242ac120002"",
                                            ""nomeArquivo"":""f7500982-6adb-11ee-b962-0242ac120002.pdf"",
                                            ""dataCriacaoArquivo"":""09/09/2023 00:00:00"",
                                            ""linkArquivo"":""https://ged.locadora.com/CTT/f7500982-6adb-11ee-b962-0242ac120002.pdf"",
                                            ""arquivo"":""oqJegy04PoxG07 + THugUPbFrmbNbGV92sC//+ODxt6/vWghhPDqIUl2QUHXSXqE+XVfgKvzPSbqBzFfOdV5pu/3UVIVVs/u3D0aPmfY5qaECx5AvMgqA3HRsmdJ0RH+cRd29zQ=="",
                                            ""tamanhoArquivo"":""1,79 MB"",
                                            ""codigoCliente"":""000122276"",
                                            ""metadados"":
                                            [
                                                {
                                                ""nome"":""SiglaDocumento"",
                                                    ""operador"":"""",
                                                    ""valor"":""CTT""
                                                },
                                                {
                                                ""nome"":""CodigoContrato"",
                                                    ""operador"":"""",
                                                    ""valor"":""XXX1234000""
                                                },
                                                {
                                                ""nome"":""Placa"",
                                                    ""operador"":"""",
                                                    ""valor"":""OMG0248""
                                                }
                                            ]
   
                                        }";

        public const string RETORNO_CNH = @"{
                                            ""identificadorArquivo"": ""67bb959c-6adc-11ee-b962-0242ac120002"",
                                            ""nomeArquivo"":""67bb959c-6adc-11ee-b962-0242ac120002.pdf"",
                                            ""dataCriacaoArquivo"":""09/09/2023 00:00:00"",
                                            ""linkArquivo"":""https://ged.locadora.com/CNH/67bb959c-6adc-11ee-b962-0242ac120002.pdf"",
                                            ""arquivo"":""nf46VuyQPx6vrFJafp3uf2xf6QFLDu8VejVBdJs0pRyL4Lk7TRp2K9BZVFuVnTDSDcW5VBFvQ + C1jXvc0SLWidOqWEQjIHNAJRhdn3hdSaZRnXD0XK499/uUd8eRXS0T/0otsQ == "",
                                            ""tamanhoArquivo"":""1,79 MB"",
                                            ""codigoCliente"":""000122276"",
                                            ""metadados"":
                                            [
                                                {
                                                ""nome"":""SiglaDocumento"",
                                                    ""operador"":"""",
                                                    ""valor"":""CNH""
                                                },
                                                {
                                                ""nome"":""DocumentoCliente"",
                                                    ""operador"":"""",
                                                    ""valor"":""13236537068""
                                                }
                                            ]
   
                                        }";

        public const string RETORNO_CPPAG = @"{
                                                ""identificadorArquivo"": ""cb70cff8-6adc-11ee-b962-0242ac120002"",
                                                ""nomeArquivo"":""cb70cff8-6adc-11ee-b962-0242ac120002.pdf"",
                                                ""dataCriacaoArquivo"":""09/09/2023 00:00:00"",
                                                ""linkArquivo"":""https://ged.locadora.com/CPPAG/cb70cff8-6adc-11ee-b962-0242ac120002.pdf"",
                                                ""arquivo"":""FU9kBe/ynw27v0zxljc0W4XVryxlpcxXwyxCekN + ENcPDUHm9cfuv8epPvcHgM8KFI7w3x3L7apSsWakvW2JwdmEusqhyPBABL8PG47v/R0MKF04tSFC1IuYShz26FPFNgCeDQ == "",
                                                ""tamanhoArquivo"":""1,79 MB"",
                                                ""codigoCliente"":""000122276"",
                                                ""metadados"":
                                                [
                                                    {
                                                    ""nome"":""SiglaDocumento"",
                                                        ""operador"":"""",
                                                        ""valor"":""CPPAG""
                                                    },
                                                {
                                                ""nome"":""CodigoContrato"",
                                                    ""operador"":"""",
                                                    ""valor"":""XXX1234000""
                                                }
                                                ]
   
                                            }";


    }
}