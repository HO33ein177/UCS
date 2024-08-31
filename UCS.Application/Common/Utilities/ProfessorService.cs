using Microsoft.AspNetCore.Mvc.Rendering;
using UCS.Domain.Entities;

namespace UCS.Application.Common.Utilities;

public class ProfessorService
{
    public static bool IsExcluded(ProfessorState state)
    {
        if ((state & ProfessorState.Educator) != 0 && (state & ProfessorState.AssistantProfessor) != 0)
        {
            return true;
        }
        
        if ((state & ProfessorState.Educator) != 0 && (state & ProfessorState.AssociateProfessor) != 0)
        {
            return true;
        }
        
        if ((state & ProfessorState.Educator) != 0 && (state & ProfessorState.FullProfessor) != 0)
        {
            return true;
        }
        
        if ((state & ProfessorState.Educator) != 0 && (state & ProfessorState.ScientificBoardMember) != 0)
        {
            return true;
        }
        
        if ((state & ProfessorState.PaidHourly) != 0 && (state & ProfessorState.PaidOnContract) != 0)
        {
            return true;
        }
        
        if ((state & ProfessorState.PartTime) != 0 && (state & ProfessorState.FullTime) != 0)
        {
            return true;
        }

        return false;
    }

    public static List<SelectListItem> GetProfessorStateSelectList()
    {
        var selectList = new List<SelectListItem>();
        var allStates = Enum.GetValues(typeof(ProfessorState)).Cast<ProfessorState>();

        int maxValue = (int)allStates.Cast<int>().Max();

        for (int i = 0; i < maxValue; i++)
        {
            var combination = (ProfessorState)i;

            if (!IsExcluded(combination))
            {
                selectList.Add(new SelectListItem
                {
                    Text = combination.ToString(),
                    Value = i.ToString()
                });
            }
        }


        return selectList;
        
    }
}