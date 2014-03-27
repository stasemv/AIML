﻿using AForge.Neuro;
using AForge.Neuro.Learning;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionRegression
{
    public class RegressionTaskV2 : RegressionTaskV1
    {
        public RegressionTaskV2()
        {
            MaxError = 0.5;
            IterationsCount = 30720;
        }

        protected override void CreateNetwork()
        {
            network = new ActivationNetwork(new Tanh(0.1), 1, 5, 1); //Меняем активационную функцию
            network.ForEachWeight(z => rnd.NextDouble() * 2 - 1);

            teacher = new BackPropagationLearning(network);
            teacher.LearningRate = 1;
        }
    }
}
