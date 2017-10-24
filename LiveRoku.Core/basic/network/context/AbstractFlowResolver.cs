﻿namespace LiveRoku.Core {
    using System;
    public abstract class AbstractFlowResolver : IFlowResolver {
        public virtual void onActive (ITransformContext ctx) {
            ctx.fireConnected ();
        }
        public virtual void onReadReady (ITransformContext ctx, object data) {
            ctx.fireReadReady (data);
        }
        public virtual void onRead (ITransformContext ctx, object data) {
            ctx.fireRead (data);
        }
        public virtual void onInactive (ITransformContext ctx, object data) {
            ctx.fireClosed (data);
        }
        public virtual void onException (ITransformContext ctx, Exception e) {
            ctx.fireException (e);
        }
    }
}