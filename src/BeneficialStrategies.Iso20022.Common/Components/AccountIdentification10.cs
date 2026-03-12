// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account identification information.
/// </summary>
[IsoId("_QSgqU9p-Ed-ak6NoX_4Aeg_-565848131")]
[DisplayName("Account Identification")]
public partial record AccountIdentification10
{
    #nullable enable
    
    /// <summary>
    /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
    /// </summary>
    [IsoId("_QSgqVNp-Ed-ak6NoX_4Aeg_-758816150")]
    [DisplayName("Identification Code")]
    [IsoXmlTag("IdCd")]
    public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    
    
    #nullable disable
    
}
