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
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType6Choice.Code))]
    [KnownType(typeof(IdentificationType6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationType6Choice.Code),nameof(IdentificationType6Choice.Code))]
    [JsonDerivedType(typeof(IdentificationType6Choice.Proprietary),nameof(IdentificationType6Choice.Proprietary))]
    #endif
    [IsoId("_QmCDQtp-Ed-ak6NoX_4Aeg_-1758873433")]
    [DisplayName("Identification Type 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationType6Choice_
    #else
    public abstract partial class IdentificationType6Choice_
    #endif
    {
    }
}
