using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiseaseDetection.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

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

        internal static readonly DiseasePrediction DP1 = new DiseasePrediction
        {
            UserId = "1",
            UserAge= 56,
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
