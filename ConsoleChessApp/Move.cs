﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessApp {
    struct Move {
        public readonly Vector2Int StartSquare;
        public readonly Vector2Int TargetSquare;
        public readonly bool IsCastleMove;
        public readonly Piece.PieceType PromoteTo;

        //if it's a castle move then StartSquare and TargetSquare correspond to king's start and end square
        public Move(Vector2Int start_square, Vector2Int target_square, bool is_castle_move, Piece.PieceType promote_to=Piece.PieceType.None) {
            StartSquare = start_square;
            TargetSquare = target_square;
            IsCastleMove = is_castle_move;
            PromoteTo = promote_to;
        }
    }
}
