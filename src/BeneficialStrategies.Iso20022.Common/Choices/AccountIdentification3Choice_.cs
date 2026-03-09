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
    /// Unique identifier of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification3Choice.IBAN))]
    [KnownType(typeof(AccountIdentification3Choice.BBAN))]
    [KnownType(typeof(AccountIdentification3Choice.UPIC))]
    [KnownType(typeof(AccountIdentification3Choice.ProprietaryAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification3Choice.IBAN),nameof(AccountIdentification3Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification3Choice.BBAN),nameof(AccountIdentification3Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification3Choice.UPIC),nameof(AccountIdentification3Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification3Choice.ProprietaryAccount),nameof(AccountIdentification3Choice.ProprietaryAccount))]
    #endif
    [IsoId("_PdnCpdp-Ed-ak6NoX_4Aeg_637192562")]
    [DisplayName("Account Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification3Choice_
    #else
    public abstract partial class AccountIdentification3Choice_
    #endif
    {
    }
}
