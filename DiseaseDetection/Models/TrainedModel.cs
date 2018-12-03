using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static DiseaseDetection.Models.ClassificationModel;

namespace DiseaseDetection.Models
{
    public class TrainedModel
    {
        internal static readonly DiseasePrediction DP1 = new DiseasePrediction
        {
            UserId = "1",
            UserAge = 56,
            UserCode = "YZ",
            BMICount = 35,
            ClucoseCount = 130,
            BloodPressureCount = 82,
            SkinThicknessCount = "2.335",
            IsPredictedWithDisease = true
        };
        internal static readonly DiseasePrediction DP2 = new DiseasePrediction
        {
            UserId = "2",
            UserCode = "XY",
            BMICount = 27,
            ClucoseCount = 130,
            BloodPressureCount = 82,
            SkinThicknessCount = "2.335",
            IsPredictedWithDisease = false
        };
    }
}