﻿using System;
using ArtificialIntelligence.Models.Algorithms;

namespace ArtificialIntelligence.Models
{
    public class NQueensProblem
    {
        private static Chessboard _chessboard;
        private Algorithm _algorithm;

        public NQueensProblem()
        {
         
        }

        public NQueensProblem(int size)
        {
            _chessboard = new Chessboard(size);
        }

        public void SetAlgorithm(Algorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public Chessboard GetResultBoard()
        {
            return _chessboard;
        }

        public void SolvedProblemExample()
        {
            _chessboard.Board[0, 1] = ChessPiece.Queen;
            _chessboard.Board[1, 3] = ChessPiece.Queen;
            _chessboard.Board[2, 0] = ChessPiece.Queen;
            _chessboard.Board[3, 2] = ChessPiece.Queen;
        }
        public void UnsolvedProblemExample()
        {
            _chessboard.Board[0, 0] = ChessPiece.Queen;
            _chessboard.Board[0, 1] = ChessPiece.Queen;
            _chessboard.Board[0, 2] = ChessPiece.Queen;
            _chessboard.Board[0, 3] = ChessPiece.Queen;
        }

        public void SetRandomBoardState()
        {
            for (int x = 0; x < _chessboard.Size; x++)
            {
                Random random = new Random();
                int y = random.Next(0, _chessboard.Size);

                _chessboard.Board[y, x] = ChessPiece.Queen;
            }
        }

        public void DoAlgorithm()
        {
            if(_algorithm != null)
            {
                _algorithm.SolveProblem(_chessboard);
            }
            else
            {
                _algorithm = new HillClimbingAlgorithm(); // we will use it just to calculate heuristic, not to do hillclimbing algorithm
                _chessboard.HeuristicResult = _algorithm.Heuristic(_chessboard.Board, _chessboard.Size);
            }
        }

        public void SetMaximumNumberOfSteps(uint number)
        {
            _chessboard.Parameters.MaximumNumberOfSteps = number;
        }
        public void SetStartingTemperature(int temperature)
        {
            _chessboard.Parameters.StartingTemperature = temperature;
        }
        public void SetCoolingFactor(int coolingFactor)
        {
            _chessboard.Parameters.CoolingFactor = coolingFactor;
        }
        public void SetNumberOfStates(uint number)
        {
            _chessboard.Parameters.NumberOfStates = number;
        }
        public void SetSizeOfSingleGeneration(int number)
        {
            _chessboard.Parameters.SizeOfSingleGeneration = number;
        }
        public void SetPercentOfElitism(int number)
        {
            _chessboard.Parameters.PercentOfElitism = number;
        }
        public void SetCrossoverProbability(int number)
        {
            _chessboard.Parameters.CrossoverProbability = number;
        }
        public void SetMutationProbability(int number)
        {
            _chessboard.Parameters.MutationProbability = number;
        }
        public void SetNumberOfGenerations(int number)
        {
            _chessboard.Parameters.NumberOfGenerations = number;
        }
    }
}
