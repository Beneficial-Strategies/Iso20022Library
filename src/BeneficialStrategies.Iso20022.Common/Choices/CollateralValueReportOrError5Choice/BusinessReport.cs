// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralValueReportOrError5Choice
{
    /// <summary>
    /// Provides information specific to the collateral value reports included in the message.
    /// </summary>
    [IsoId("_-DiXcTpvEemk2e6qGBk8IQ")]
    [DisplayName("Business Report")]
    public partial record BusinessReport : CollateralValueReportOrError5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the account servicer, to unambiguously identify the account on which information is requested.
        /// </summary>
        [IsoId("_-ORAwTpvEemk2e6qGBk8IQ")]
        [DisplayName("Cash Account")]
        [IsoXmlTag("CshAcct")]
        public required CashAccount38 CashAccount { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_wBoGcjpwEemk2e6qGBk8IQ")]
        [DisplayName("Cash Account Owner")]
        [IsoXmlTag("CshAcctOwnr")]
        public SystemPartyIdentification11? CashAccountOwner { get; init; } 
        
        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_wBoGczpwEemk2e6qGBk8IQ")]
        [DisplayName("Cash Account Servicer")]
        [IsoXmlTag("CshAcctSvcr")]
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identification of the securities account owner.
        /// </summary>
        [IsoId("_-ORAwzpvEemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Owner")]
        [IsoXmlTag("SctiesAcctOwnr")]
        public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; } 
        
        /// <summary>
        /// Party that manages the securities account on behalf of the account owner.
        /// </summary>
        [IsoId("_-ORAxTpvEemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Servicer")]
        [IsoXmlTag("SctiesAcctSvcr")]
        public PartyIdentification136? SecuritiesAccountServicer { get; init; } 
        
        /// <summary>
        /// Provides information specific to the report on collateral value positions.
        /// </summary>
        [IsoId("_-ORAxzpvEemk2e6qGBk8IQ")]
        [DisplayName("Collateral Value Report")]
        [IsoXmlTag("CollValRpt")]
        public CollateralValueReportOrError6Choice_? CollateralValueReport { get; init; } 
        
        
        #nullable disable
        
    }
}
