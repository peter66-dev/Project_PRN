﻿using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PetRepository : IPetRepository
    {
        public PetObject GetPetByPetID(int id) => PetDAO.Instance.GetPetByPetID(id);

        public List<PetObject> GetPetList() => PetDAO.Instance.GetPetList();

        public void InsertPet(PetObject pet) => PetDAO.Instance.InsertPet(pet);

        public void RemovePet(int id) => PetDAO.Instance.RemovePet(id);

        public void UpdatePet(PetObject pet) => PetDAO.Instance.UpdatePet(pet);
    }
}
