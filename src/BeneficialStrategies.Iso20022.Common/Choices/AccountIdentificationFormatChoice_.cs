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
    /// Choice between formats for account identification.
    /// </summary>
    [KnownType(typeof(AccountIdentificationFormatChoice.SimpleIdentification))]
    [KnownType(typeof(AccountIdentificationFormatChoice.IdentificationAndPurpose))]
    [KnownType(typeof(AccountIdentificationFormatChoice.IdentificationAsDSS))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentificationFormatChoice.SimpleIdentification),nameof(AccountIdentificationFormatChoice.SimpleIdentification))]
    [JsonDerivedType(typeof(AccountIdentificationFormatChoice.IdentificationAndPurpose),nameof(AccountIdentificationFormatChoice.IdentificationAndPurpose))]
    [JsonDerivedType(typeof(AccountIdentificationFormatChoice.IdentificationAsDSS),nameof(AccountIdentificationFormatChoice.IdentificationAsDSS))]
    #endif
    [IsoId("_RBvu5dp-Ed-ak6NoX_4Aeg_1713990380")]
    [DisplayName("Account Identification Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentificationFormatChoice_
    #else
    public abstract partial class AccountIdentificationFormatChoice_
    #endif
    {
    }
}
