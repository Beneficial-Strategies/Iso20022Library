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
    /// Choice of formats to express the processing status of an advice, a request or a movement.
    /// </summary>
    [KnownType(typeof(ProcessedStatus3FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus3FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessedStatus3FormatChoice.Code),nameof(ProcessedStatus3FormatChoice.Code))]
    [JsonDerivedType(typeof(ProcessedStatus3FormatChoice.Proprietary),nameof(ProcessedStatus3FormatChoice.Proprietary))]
    #endif
    [IsoId("_RnTTBNp-Ed-ak6NoX_4Aeg_1585305057")]
    [DisplayName("Processed Status 3 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessedStatus3FormatChoice_
    #else
    public abstract partial class ProcessedStatus3FormatChoice_
    #endif
    {
    }
}
