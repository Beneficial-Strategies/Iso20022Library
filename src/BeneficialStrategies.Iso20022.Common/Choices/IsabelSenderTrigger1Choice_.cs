// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the trigger used by the sender to generate the file.
    /// </summary>
    [KnownType(typeof(IsabelSenderTrigger1Choice.Code))]
    [KnownType(typeof(IsabelSenderTrigger1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IsabelSenderTrigger1Choice.Code),nameof(IsabelSenderTrigger1Choice.Code))]
    [JsonDerivedType(typeof(IsabelSenderTrigger1Choice.Proprietary),nameof(IsabelSenderTrigger1Choice.Proprietary))]
    #endif
    [IsoId("_Xmro0MmLEeWAGphE2LvqeA")]
    [DisplayName("Isabel Sender Trigger 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IsabelSenderTrigger1Choice_
    #else
    public abstract partial class IsabelSenderTrigger1Choice_
    #endif
    {
    }
}
