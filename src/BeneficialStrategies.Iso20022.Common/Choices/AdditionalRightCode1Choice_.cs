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
    /// Choice of additional right code.
    /// </summary>
    [KnownType(typeof(AdditionalRightCode1Choice.Code))]
    [KnownType(typeof(AdditionalRightCode1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdditionalRightCode1Choice.Code),nameof(AdditionalRightCode1Choice.Code))]
    [JsonDerivedType(typeof(AdditionalRightCode1Choice.Proprietary),nameof(AdditionalRightCode1Choice.Proprietary))]
    #endif
    [IsoId("_RDYto9p-Ed-ak6NoX_4Aeg_-1284935135")]
    [DisplayName("Additional Right Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalRightCode1Choice_
    #else
    public abstract partial class AdditionalRightCode1Choice_
    #endif
    {
    }
}
