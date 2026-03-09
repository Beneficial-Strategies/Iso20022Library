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
    /// Sets of elements to identify a name of the identification scheme.
    /// </summary>
    [KnownType(typeof(PersonIdentificationSchemeName1Choice.Code))]
    [KnownType(typeof(PersonIdentificationSchemeName1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PersonIdentificationSchemeName1Choice.Code),nameof(PersonIdentificationSchemeName1Choice.Code))]
    [JsonDerivedType(typeof(PersonIdentificationSchemeName1Choice.Proprietary),nameof(PersonIdentificationSchemeName1Choice.Proprietary))]
    #endif
    [IsoId("_P_4pQ9p-Ed-ak6NoX_4Aeg_2056543129")]
    [DisplayName("Person Identification Scheme Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PersonIdentificationSchemeName1Choice_
    #else
    public abstract partial class PersonIdentificationSchemeName1Choice_
    #endif
    {
    }
}
