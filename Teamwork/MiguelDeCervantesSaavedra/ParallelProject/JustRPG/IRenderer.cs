﻿namespace JustRPG
{
    public interface IRenderer
    {
        void EnqueueForRendering(IRenderable obj);

        void RenderAll();

        void ClearQueue();
    }
}
