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
    /// Choice of formats for the type of organisation.
    /// </summary>
    [KnownType(typeof(OrganisationType1Choice.Code))]
    [KnownType(typeof(OrganisationType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OrganisationType1Choice.Code),nameof(OrganisationType1Choice.Code))]
    [JsonDerivedType(typeof(OrganisationType1Choice.Proprietary),nameof(OrganisationType1Choice.Proprietary))]
    #endif
    [IsoId("_wpZ08CCeEeWJd9HF2tO7BA")]
    [DisplayName("Organisation Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrganisationType1Choice_
    #else
    public abstract partial class OrganisationType1Choice_
    #endif
    {
    }
}
