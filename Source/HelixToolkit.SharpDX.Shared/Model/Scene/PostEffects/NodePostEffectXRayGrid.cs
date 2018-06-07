﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using SharpDX;
using System.Collections.Generic;

#if NETFX_CORE
namespace HelixToolkit.UWP.Model.Scene
#else
namespace HelixToolkit.Wpf.SharpDX.Model.Scene
#endif
{
    using Core;
    /// <summary>
    /// 
    /// </summary>
    public class NodePostEffectXRayGrid : SceneNode
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name of the effect.
        /// </summary>
        /// <value>
        /// The name of the effect.
        /// </value>
        public string EffectName
        {
            set
            {
                (RenderCore as IPostEffect).EffectName = value;
            }
            get
            {
                return (RenderCore as IPostEffect).EffectName;
            }
        }
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public Color4 Color
        {
            set
            {
                (RenderCore as IPostEffectMeshXRayGrid).Color = value;
            }
            get
            {
                return (RenderCore as IPostEffectMeshXRayGrid).Color;
            }
        }
        /// <summary>
        /// Gets or sets the grid density.
        /// </summary>
        /// <value>
        /// The grid density.
        /// </value>
        public int GridDensity
        {
            set
            {
                (RenderCore as IPostEffectMeshXRayGrid).GridDensity = value;
            }
            get
            {
                return (RenderCore as IPostEffectMeshXRayGrid).GridDensity;
            }
        }
        /// <summary>
        /// Gets or sets the dimming factor.
        /// </summary>
        /// <value>
        /// The dimming factor.
        /// </value>
        public float DimmingFactor
        {
            set
            {
                (RenderCore as IPostEffectMeshXRayGrid).DimmingFactor = value;
            }
            get
            {
                return (RenderCore as IPostEffectMeshXRayGrid).DimmingFactor;
            }
        }

        #endregion

        /// <summary>
        /// Called when [create render core].
        /// </summary>
        /// <returns></returns>
        protected override RenderCore OnCreateRenderCore()
        {
            return new PostEffectMeshXRayGridCore();
        }

        protected override bool CanHitTest(RenderContext context)
        {
            return false;
        }
        protected override bool OnHitTest(RenderContext context, Matrix totalModelMatrix, ref Ray ray, ref List<HitTestResult> hits)
        {
            return false;
        }
    }
}
