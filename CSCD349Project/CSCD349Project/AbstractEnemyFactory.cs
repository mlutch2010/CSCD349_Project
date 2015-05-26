using System;
//Could potentially be an interface...
namespace CSCD349Project
{
    public abstract class AbstractEnemyFactory
    {
        public AbstractEnemyFactory()
        { }

        abstract public GameCharacter GetRandomGameCharacter();

    }
}
