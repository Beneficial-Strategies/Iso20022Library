// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ContractTerm7Choice
{
    /// <summary>
    /// Transaction is open term, that is, has no fixed maturity date.
    /// </summary>
    [IsoId("_xsKXYa5qEeuo-IflVgGqiA")]
    [DisplayName("Open")]
    public partial record Open : ContractTerm7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction.
        /// </summary>
        [IsoId("_x8jj0a5qEeuo-IflVgGqiA")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? MaturityDate { get; init; } 
        
        /// <summary>
        /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable agreement.
        /// </summary>
        [IsoId("_x8jj065qEeuo-IflVgGqiA")]
        [DisplayName("Termination Option")]
        [IsoXmlTag("TermntnOptn")]
        public RepoTerminationOption2Code? TerminationOption { get; init; } 
        
        
        #nullable disable
        
    }
}
