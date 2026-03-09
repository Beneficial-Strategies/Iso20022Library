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
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat7Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat7Choice.Code),nameof(AdditionalBusinessProcessFormat7Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat7Choice.Proprietary),nameof(AdditionalBusinessProcessFormat7Choice.Proprietary))]
    #endif
    [IsoId("_64ajEfpNEeCLrd06h-p51g")]
    [DisplayName("Additional Business Process Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat7Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat7Choice_
    #endif
    {
    }
}
