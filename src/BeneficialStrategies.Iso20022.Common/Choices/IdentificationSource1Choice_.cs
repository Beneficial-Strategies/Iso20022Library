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
    /// Choice of proprietary or domestic identification scheme that uniquely identifies a security.
    /// </summary>
    [KnownType(typeof(IdentificationSource1Choice.Domestic))]
    [KnownType(typeof(IdentificationSource1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationSource1Choice.Domestic),nameof(IdentificationSource1Choice.Domestic))]
    [JsonDerivedType(typeof(IdentificationSource1Choice.Proprietary),nameof(IdentificationSource1Choice.Proprietary))]
    #endif
    [IsoId("_RCMa1Np-Ed-ak6NoX_4Aeg_-823222621")]
    [DisplayName("Identification Source 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationSource1Choice_
    #else
    public abstract partial class IdentificationSource1Choice_
    #endif
    {
    }
}
