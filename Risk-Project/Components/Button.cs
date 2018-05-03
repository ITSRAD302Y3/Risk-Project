using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Risk_Project.Components
{
    class Button
    {
        #region Properties
        public string Name;
        private Board.Action buttonAction;
        #endregion

        #region Constructor
        public Button(Board.Action action)
        {
            this.buttonAction = action;
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
