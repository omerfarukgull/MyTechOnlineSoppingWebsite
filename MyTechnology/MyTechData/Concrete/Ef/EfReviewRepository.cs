﻿using MyTechData.Abstract;
using MyTechEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTechData.Concrete.Ef
{
    public class EfReviewRepository:EfGenericRepository<Review,TechContext>,IReviewRepository
    {
    }
}