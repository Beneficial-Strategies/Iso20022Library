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
    /// Ancillary identification information about the party.
    /// </summary>
    [KnownType(typeof(PartyAdditionalIdentification2Choice.BirthDate))]
    [KnownType(typeof(PartyAdditionalIdentification2Choice.RegistrationIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyAdditionalIdentification2Choice.BirthDate),nameof(PartyAdditionalIdentification2Choice.BirthDate))]
    [JsonDerivedType(typeof(PartyAdditionalIdentification2Choice.RegistrationIdentification),nameof(PartyAdditionalIdentification2Choice.RegistrationIdentification))]
    #endif
    [IsoId("_Qo3U0dp-Ed-ak6NoX_4Aeg_1365227120")]
    [DisplayName("Party Additional Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyAdditionalIdentification2Choice_
    #else
    public abstract partial class PartyAdditionalIdentification2Choice_
    #endif
    {
    }
}
