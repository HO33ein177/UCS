using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCS.Domain.Entities;

public class Professor: ApplicationUser
{
  
    public ProfessorState State { get; set; }

    
    
}