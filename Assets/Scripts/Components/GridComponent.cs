﻿using Assets.Scripts.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class GridComponent : MonoBehaviour
    {
        public GameObject EmptyTile;
        public GameObject ArcherTile;
        public GameObject WizardTile;
        public GameObject KnightTile;
        public GameObject DragonTile;
        public GameObject InfantryTile;

        public Battleground Battleground;
        public Game Game;

        private List<GameObject> _objects;

        private void Start()
        {
            _objects = new List<GameObject>();

            Battleground.Changed += UpdateGrid;
            GenerateGrid();
        }

        private void GenerateGrid()
        {
            for (int x = 0; x < Battleground.Width; x++)
                for (int y = 0; y < Battleground.Height; y++)
                {
                    var tile = Place(x, y);
                    _objects.Add(tile);

                    tile.name = $"Tile[{x}, {y}]";
                    tile.transform.position = new Vector2(x, y);
                }

            GameObject Place(int x, int y)
            {
                var tile = Battleground[x, y];
                GameObject @object = null;

                if (tile == null)
                    return Instantiate(EmptyTile, transform);

                if (tile.Type == Unit.Type.Archer)
                    @object = Instantiate(ArcherTile, transform);
                if (tile.Type == Unit.Type.Wizard)
                    @object = Instantiate(WizardTile, transform);
                if (tile.Type == Unit.Type.Dragon)
                    @object = Instantiate(DragonTile, transform);
                if (tile.Type == Unit.Type.Infantry)
                    @object = Instantiate(InfantryTile, transform);
                if (tile.Type == Unit.Type.Knight)
                    @object = Instantiate(KnightTile, transform);

                if (x == Battleground.Width - 1)
                {
                    var sprite = @object.GetComponent<SpriteRenderer>();
                    sprite.flipX = true;
                }

                return @object;
            }
        }

        private void UpdateGrid()
        {
            foreach (var @object in _objects)
                Destroy(@object);

            GenerateGrid();
        }
    }
}