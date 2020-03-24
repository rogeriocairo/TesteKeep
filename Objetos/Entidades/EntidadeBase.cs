﻿using System;

namespace Objetos.Entidades
{
    public abstract class EntidadeBase
    {
        Guid _Id;

        public EntidadeBase()
        {
            _Id = Guid.NewGuid();
        }

        public virtual Guid Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }
    }
}
