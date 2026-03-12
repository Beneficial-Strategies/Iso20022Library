// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio9Choice
{
    /// <summary>
    /// Portfolio is a pension policy, plan or scheme.
    /// </summary>
    [IsoId("_ZYn_xelqEeuvhrZwLF0fDg")]
    [DisplayName("Pension")]
    public partial record Pension : FundPortfolio9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_YsEbwelqEeuvhrZwLF0fDg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PensionPolicy1? Identification { get; init; } 
        
        /// <summary>
        /// Type of pension policy, plan or scheme.
        /// </summary>
        [IsoId("_YsEbw-lqEeuvhrZwLF0fDg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public PensionSchemeType3Choice_? Type { get; init; } 
        
        /// <summary>
        /// Scope of the pension policy, plan or scheme transfer.
        /// </summary>
        [IsoId("_YsEbxelqEeuvhrZwLF0fDg")]
        [DisplayName("Transfer Scope")]
        [IsoXmlTag("TrfScp")]
        public PensionTransferScope1Choice_? TransferScope { get; init; } 
        
        /// <summary>
        /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
        /// </summary>
        [IsoId("_YsEbx-lqEeuvhrZwLF0fDg")]
        [DisplayName("Tax Reference")]
        [IsoXmlTag("TaxRef")]
        public TaxReference1? TaxReference { get; init; } 
        
        /// <summary>
        /// Reference of the drawdown.
        /// </summary>
        [IsoId("_YsEbyelqEeuvhrZwLF0fDg")]
        [DisplayName("Drawdown Tranche Identification")]
        [IsoXmlTag("DrwdwnTrchId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
        
        /// <summary>
        /// Indicates that the transfer is only in relation to underlying assets, and that the wrapper transfer will occur separately.
        /// </summary>
        [IsoId("_cyN8UOlrEeuvhrZwLF0fDg")]
        [DisplayName("Non Wrapper Transfer")]
        [IsoXmlTag("NonWrpprTrf")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? NonWrapperTransfer { get; init; } 
        
        /// <summary>
        /// Additional information about the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_YsEby-lqEeuvhrZwLF0fDg")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
