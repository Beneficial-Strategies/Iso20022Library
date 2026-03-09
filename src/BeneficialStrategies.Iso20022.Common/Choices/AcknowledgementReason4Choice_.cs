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
    [KnownType(typeof(AcknowledgementReason4Choice.Code))]
    [KnownType(typeof(AcknowledgementReason4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcknowledgementReason4Choice.Code),nameof(AcknowledgementReason4Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason4Choice.Proprietary),nameof(AcknowledgementReason4Choice.Proprietary))]
    #endif
    [IsoId("_UZEQBtp-Ed-ak6NoX_4Aeg_-1118171276")]
    [DisplayName("Acknowledgement Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgementReason4Choice_
    #else
    public abstract partial class AcknowledgementReason4Choice_
    #endif
    {
    }
}
