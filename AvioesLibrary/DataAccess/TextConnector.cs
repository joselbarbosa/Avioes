﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvioesLibrary.Models;

namespace AvioesLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreateCliente for text files
        public ClienteModel CreateCliente(ClienteModel model)
        {
            model.Id = 1;

            return model;
        }

        public BagagemModel CreateBagagem(BagagemModel model)
        {
            model.Id = 1;

            return model;
        }

        public BagagemModel DeleteBagagem(BagagemModel model)
        {
            model.Id = 1;

            return model;
        }

        public BagagemModel UpdateBagagem(BagagemModel model)
        {
            model.Id = 1;

            return model;
        }

        public VooModel CreateVoo(VooModel model)
        {
            model.Id = 1;

            return model;
        }

        public ReservaModel CreateReserva(ReservaModel model)
        {
            model.Id = 1;

            return model;
        }

        public ReservaModel DeleteReserva(ReservaModel model)
        {
            model.Id = 1;

            return model;
        }

        public ReservaModel SelectReserva(ReservaModel model)
        {
            model.Id = 1;

            return model;
        }

        public ReservaModel UpdateReserva(ReservaModel model)
        {
            model.Id = 1;

            return model;
        }

        public List<BagagemModel> GetBagagem_All()
        {
            throw new NotImplementedException();
        }

        public ClienteBagsModel CreateClienteBags(ClienteBagsModel model)
        {
            throw new NotImplementedException();
        }
    }
}
