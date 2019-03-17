using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsanaBuilder.DAL;
using AsanaBuilder.Models;

namespace AsanaBuilder.Controllers
{
    public class SequencesController : Controller
    {
        private ISequenceDAO sequenceDAO;
        private IPoseDAO poseDAO;

        public SequencesController(ISequenceDAO sequenceDAO, IPoseDAO poseDAO)
        {
            this.sequenceDAO = sequenceDAO;
            this.poseDAO = poseDAO;
        }
        public IActionResult ViewSequences()
        {
            IList<Sequence> sequences = sequenceDAO.GetAllSequences();
            return View(sequences);
        }
    }
}