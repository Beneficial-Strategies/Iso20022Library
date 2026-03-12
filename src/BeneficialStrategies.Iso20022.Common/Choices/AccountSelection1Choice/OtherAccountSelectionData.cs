// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountSelection1Choice
{
    /// <summary>
    /// Various investment account information used to select a specific account.
    /// </summary>
    [IsoId("_RjijYyFSEeWgV9SQSyaAog")]
    [DisplayName("Other Account Selection Data")]
    public partial record OtherAccountSelectionData : AccountSelection1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
        /// </summary>
        [IsoId("_zWVvhSFSEeWgV9SQSyaAog")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Name { get; init; } 
        
        /// <summary>
        /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
        /// </summary>
        [IsoId("_zWVvhyFSEeWgV9SQSyaAog")]
        [DisplayName("Designation")]
        [IsoXmlTag("Dsgnt")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Designation { get; init; } 
        
        /// <summary>
        /// Legal form of the fund, for example, UCITS, SICAV, OEIC, Unit Trust, and FCP.
        /// </summary>
        [IsoId("_zWVviSFSEeWgV9SQSyaAog")]
        [DisplayName("Fund Type")]
        [IsoXmlTag("FndTp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? FundType { get; init; } 
        
        /// <summary>
        /// Name of the investment fund family.
        /// </summary>
        [IsoId("_zWVviyFSEeWgV9SQSyaAog")]
        [DisplayName("Fund Family Name")]
        [IsoXmlTag("FndFmlyNm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? FundFamilyName { get; init; } 
        
        /// <summary>
        /// Detailed information about the investment fund associated to the account.
        /// </summary>
        [IsoId("_zWVvjSFSEeWgV9SQSyaAog")]
        [DisplayName("Security Details")]
        [IsoXmlTag("SctyDtls")]
        public FinancialInstrument45? SecurityDetails { get; init; } 
        
        /// <summary>
        /// Owner of the account.
        /// </summary>
        [IsoId("_fF8jACFTEeWgV9SQSyaAog")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public AccountOwner1Choice_? AccountOwner { get; init; } 
        
        /// <summary>
        /// Intermediary or other party related to the management of the account. In some markets, when this intermediary is a party acting on behalf of the investor for which it has opened an account at, for example, a central securities depository or international central securities depository, this party is known by the investor as the &apos;account controller&apos;.
        /// </summary>
        [IsoId("_zWVvkyFSEeWgV9SQSyaAog")]
        [DisplayName("Intermediary")]
        [IsoXmlTag("Intrmy")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Intermediary33> Intermediary { get; init; } = new ValueList<Intermediary33>(){};
        
        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_zWVvlSFSEeWgV9SQSyaAog")]
        [DisplayName("Account Servicer")]
        [IsoXmlTag("AcctSvcr")]
        public PartyIdentification70Choice_? AccountServicer { get; init; } 
        
        
        #nullable disable
        
    }
}
