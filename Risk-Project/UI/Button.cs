using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Risk_Project.Components;
using Risk_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk_Project.UI
{
    class Button
    {
        #region Properties
        public string Name;
        private Sprite texture;
        private SpriteFont UIFont;
        private Board.Action buttonAction;
        #endregion

        #region Constructor
        public Button(string name, Board.Action action, SpriteFont uiFont, Sprite texture)
        {
            Name = name;
            buttonAction = action;
            UIFont = uiFont;
            this.texture = texture;
        }
        #endregion

        #region Methods
        public void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public Board.Action CheckAction()
        {
            // If I'm clicked.
            return buttonAction;
        }

        public void Zoom(bool zoomIn)
        {
            if (zoomIn)
            {
                // Zoom camera in.
            }
            else
            {
                // Zoom camera out.
            }
        }

        #endregion
    }
}
