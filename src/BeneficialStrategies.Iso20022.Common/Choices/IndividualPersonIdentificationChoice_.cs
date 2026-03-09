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
    /// Choice of identification of an individual person.
    /// </summary>
    [KnownType(typeof(IndividualPersonIdentificationChoice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentificationChoice.PersonName))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IndividualPersonIdentificationChoice.IdentificationNumber),nameof(IndividualPersonIdentificationChoice.IdentificationNumber))]
    [JsonDerivedType(typeof(IndividualPersonIdentificationChoice.PersonName),nameof(IndividualPersonIdentificationChoice.PersonName))]
    #endif
    [IsoId("_REuxfNp-Ed-ak6NoX_4Aeg_-925696504")]
    [DisplayName("Individual Person Identification Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndividualPersonIdentificationChoice_
    #else
    public abstract partial class IndividualPersonIdentificationChoice_
    #endif
    {
    }
}
