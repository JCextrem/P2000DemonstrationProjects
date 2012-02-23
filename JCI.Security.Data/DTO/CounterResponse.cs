﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCI.Security.Data.DTO
{
    public class CounterResponse
    {
        /// Guid of alarm                 
        public Guid ItemGuid { get; set; }

        /// Alarm Name                          
        public string ItemName { get; set; }

        /// Guid of partition which owns this alarm
        public Guid PartitionGuid { get; set; }

        /// <summary>
        /// Name of partition which owns this alarm
        /// </summary>
        /// <value>
        /// The name of the partition.
        /// </value>
        /// 
        public string PartitionName { get; set; }

        /// <summary>
        /// Signed 32-bit values of the counter
        /// </summary>
        public int ItemValue { get; set; }
        
        /// 0 = non-public, 1 = public                           
        public bool Public { get; set; }

    }
}
