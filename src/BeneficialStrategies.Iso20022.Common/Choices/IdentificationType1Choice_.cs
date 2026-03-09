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
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [KnownType(typeof(IdentificationType1Choice.IdentificationType))]
    [KnownType(typeof(IdentificationType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationType1Choice.IdentificationType),nameof(IdentificationType1Choice.IdentificationType))]
    [JsonDerivedType(typeof(IdentificationType1Choice.Proprietary),nameof(IdentificationType1Choice.Proprietary))]
    #endif
    [IsoId("_QAoQJtp-Ed-ak6NoX_4Aeg_-1560497991")]
    [DisplayName("Identification Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationType1Choice_
    #else
    public abstract partial class IdentificationType1Choice_
    #endif
    {
    }
}
