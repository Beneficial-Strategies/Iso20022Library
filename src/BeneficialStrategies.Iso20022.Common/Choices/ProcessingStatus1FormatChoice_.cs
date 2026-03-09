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
    /// Choice of formats to express the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus1FormatChoice.Code))]
    [KnownType(typeof(ProcessingStatus1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus1FormatChoice.Code),nameof(ProcessingStatus1FormatChoice.Code))]
    [JsonDerivedType(typeof(ProcessingStatus1FormatChoice.Proprietary),nameof(ProcessingStatus1FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rnv-89p-Ed-ak6NoX_4Aeg_-1083184127")]
    [DisplayName("Processing Status 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus1FormatChoice_
    #else
    public abstract partial class ProcessingStatus1FormatChoice_
    #endif
    {
    }
}
