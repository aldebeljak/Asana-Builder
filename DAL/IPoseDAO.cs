using System;
using AsanaBuilder.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsanaBuilder.DAL
{
    public interface IPoseDAO
    {
        IList<Pose> GetAllPoses();
        bool AddPose(Pose pose);
        bool RemovePose(Pose pose);

    }
}
