using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiseaseDetection.Models
{
    public class ClassificationModel
    {
        public class DiseasePrediction
        {
            [Column("0")]
            public string UserId;

            [Column("1")]
            public string UserCode;

            [Column("2")]
            public float BMICount;

            [Column("3")]
            public float ClucoseCount;

            [Column("4")]
            public float BloodPressureCount;

            [Column("5")]
            public string SkinThicknessCount;

            [Column("6")]
            public bool IsPredictedWithDisease;
            [Column("7")]
            public int UserAge;
        }
        public class DiseasePrediction1
        {
            public bool IsPredictedWithDisease;
        }
    }
}