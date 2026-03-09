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
    /// Choice of format between an ISO 20022 code and a proprietary code.
    /// </summary>
    [KnownType(typeof(CodeOrProprietary1Choice.Code))]
    [KnownType(typeof(CodeOrProprietary1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CodeOrProprietary1Choice.Code),nameof(CodeOrProprietary1Choice.Code))]
    [JsonDerivedType(typeof(CodeOrProprietary1Choice.Proprietary),nameof(CodeOrProprietary1Choice.Proprietary))]
    #endif
    [IsoId("_Qotj1tp-Ed-ak6NoX_4Aeg_-1810617673")]
    [DisplayName("Code Or Proprietary 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CodeOrProprietary1Choice_
    #else
    public abstract partial class CodeOrProprietary1Choice_
    #endif
    {
    }
}
