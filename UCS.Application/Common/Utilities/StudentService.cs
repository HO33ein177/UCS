using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc.Rendering;
using UCS.Domain.Entities;


namespace UCS.Application.Common.Utilities;

public class StudentService
{
    public static bool IsExcludedCombination(StudentState state)
    {
        if ((state & StudentState.Conditional) != 0 && (state & StudentState.GpaAboveA) != 0)
        {
            return true;
        }

        if ((state & StudentState.TuitionFree) != 0 && (state & StudentState.MustPayTuition) != 0)
        {
            return true;
        }

        if ((state & StudentState.TuitionFree) != 0 && (state & StudentState.InDebt) != 0)
        {
            return true;
        }

        return false;
    }
    
    public static List<SelectListItem> GetStudentStateSelectList()
    {
        var selectList = new List<SelectListItem>();
        var allStates = Enum.GetValues(typeof(StudentState)).Cast<StudentState>();

        int maxValue = (int)allStates.Cast<int>().Max();

        for (int i = 0; i < maxValue; i++)
        {
            var combination = (StudentState)i;

            if (!IsExcludedCombination(combination))
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