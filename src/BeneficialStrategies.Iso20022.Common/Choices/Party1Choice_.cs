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
    /// Choice between the identification of a person and the identification of a non-financial institution.
    /// </summary>
    [KnownType(typeof(Party1Choice.OrganisationIdentification))]
    [KnownType(typeof(Party1Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party1Choice.OrganisationIdentification),nameof(Party1Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party1Choice.PrivateIdentification),nameof(Party1Choice.PrivateIdentification))]
    #endif
    [IsoId("_Rca4t9p-Ed-ak6NoX_4Aeg_49258998")]
    [DisplayName("Party 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party1Choice_
    #else
    public abstract partial class Party1Choice_
    #endif
    {
    }
}
