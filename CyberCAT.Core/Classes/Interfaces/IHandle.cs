﻿using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Interfaces
{
    public interface IHandle
    {
        uint GetId();
        void SetId(uint handleId);
        GenericUnknownStruct.BaseClassEntry GetValue();
        void SetValue(object value);
    }
}