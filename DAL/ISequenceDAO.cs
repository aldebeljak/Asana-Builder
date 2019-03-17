using System;
using AsanaBuilder.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsanaBuilder.DAL
{
    public interface ISequenceDAO
    {
        IList<Sequence> GetAllSequences();
        IList<Pose> GetSequencePoses();
        bool CreateSequence(Sequence sequence);
        bool DeleteSequence(Sequence sequence);
    }
}
