// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_vsxKiTbsEead9bDRE_1DAQ")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction70
{
    #nullable enable
    
    /// <summary>
    /// Choice between types of payment instrument, for example, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [IsoId("_wFdXNTbsEead9bDRE_1DAQ")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument20Choice_ PaymentInstrument { get; init; } 
    
    
    #nullable disable
    
}
