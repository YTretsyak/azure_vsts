﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
  public class StudentContext :DbContext
  {
    public StudentContext() : base("azureSQL")
    {}

    public DbSet<Student> Students { get; set; }
  }
}