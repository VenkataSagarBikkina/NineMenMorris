﻿using NUnit.Framework;
using NineMenMorris;
using GenericMorris;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace NineMenMorrisTest.UnitTests
{
    public class NineMenMorrisGameTests
    {
        private NineMenMorrisGame _nineMenMorrisGame;

        [SetUp]
        public void Setup()
        {
            _nineMenMorrisGame = new NineMenMorrisGame();
        }

        [Test]
        public void testPointState()
        {
            Assert.AreEqual(PointState.Empty,_nineMenMorrisGame.GetPointState(NineMensPointList.POINT_A1));
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A1);
            Assert.AreEqual(PointState.WhitePlaced, _nineMenMorrisGame.GetPointState(NineMensPointList.POINT_A1));
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A4);
            Assert.AreEqual(PointState.BlackPlaced, _nineMenMorrisGame.GetPointState(NineMensPointList.POINT_A4));
        }

        [Test]
        public void testPlayerTurn()
        {
            Assert.AreEqual(PlayerTurn.White, _nineMenMorrisGame.GetPlayerTurn());
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A1);
            Assert.AreEqual(PlayerTurn.Black, _nineMenMorrisGame.GetPlayerTurn());
        }

        private void CompletePiecePlacement()
        {
            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A1);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A4);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_B2);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_C3);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_B4);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_C4);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_E5);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_E3);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_G1);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_G7);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_G4);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_F6);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_D7);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_D2);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_F2);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_D1);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A7);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_E4);
        }
        [Test]
        public void testGameState()
        {
            Assert.AreEqual(GameState.PlacingPieces, _nineMenMorrisGame.GetGameState());
            CompletePiecePlacement();
            Assert.AreEqual(GameState.PiecesPlaced, _nineMenMorrisGame.GetGameState());
        }

    }
}