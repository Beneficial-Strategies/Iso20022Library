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
    /// Choice of formats to express the processing status of a deactivation instruction.
    /// </summary>
    [KnownType(typeof(ProcessedStatus6FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus6FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessedStatus6FormatChoice.Code),nameof(ProcessedStatus6FormatChoice.Code))]
    [JsonDerivedType(typeof(ProcessedStatus6FormatChoice.Proprietary),nameof(ProcessedStatus6FormatChoice.Proprietary))]
    #endif
    [IsoId("_RnmN9dp-Ed-ak6NoX_4Aeg_-344158716")]
    [DisplayName("Processed Status 6 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessedStatus6FormatChoice_
    #else
    public abstract partial class ProcessedStatus6FormatChoice_
    #endif
    {
    }
}
