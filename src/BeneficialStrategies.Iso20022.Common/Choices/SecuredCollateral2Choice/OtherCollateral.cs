// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral2Choice
{
    /// <summary>
    /// Identifies the collateral when the asset class pledged as collateral does not correspond to an ISIN.
    /// </summary>
    [IsoId("_iZO6B6idEeWHO_l3hf2rlA")]
    [DisplayName("Other Collateral")]
    public partial record OtherCollateral : SecuredCollateral2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies whether the collateral is a pool collateral or not.
        /// </summary>
        [IsoId("_oPGhMaidEeWHO_l3hf2rlA")]
        [DisplayName("Pool Status")]
        [IsoXmlTag("PoolSts")]
        public required CollateralPool1Code PoolStatus { get; init; } 
        
        /// <summary>
        /// Identifies the asset class pledged as collateral, expressed as an ISO 10962 Classification of Financial Instrument (CFI).
        /// </summary>
        [IsoId("_oPGhM6idEeWHO_l3hf2rlA")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
        public required IsoCFIOct2015Identifier Type { get; init; } 
        
        /// <summary>
        /// Provides the institutional sector, such as central government, central bank, etc. of the issuer of collateral.
        /// </summary>
        [IsoId("_oPGhNaidEeWHO_l3hf2rlA")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        public required IsoSNA2008SectorIdentifier Sector { get; init; } 
        
        /// <summary>
        /// Nominal amount of money of the security pledged as collateral, when the collateral cannot be identified through an individual or basket ISIN.
        /// </summary>
        [IsoId("_oPGhN6idEeWHO_l3hf2rlA")]
        [DisplayName("Nominal Amount")]
        [IsoXmlTag("NmnlAmt")]
        public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
        
        
        #nullable disable
        
    }
}
