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
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason1Choice.Code))]
    [KnownType(typeof(AcknowledgementReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcknowledgementReason1Choice.Code),nameof(AcknowledgementReason1Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason1Choice.Proprietary),nameof(AcknowledgementReason1Choice.Proprietary))]
    #endif
    [IsoId("_UXuzR9p-Ed-ak6NoX_4Aeg_-355998535")]
    [DisplayName("Acknowledgement Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgementReason1Choice_
    #else
    public abstract partial class AcknowledgementReason1Choice_
    #endif
    {
    }
}
