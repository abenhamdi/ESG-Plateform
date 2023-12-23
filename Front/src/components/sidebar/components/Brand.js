import React from "react";

// Chakra imports
import { Flex, useColorModeValue, Image } from "@chakra-ui/react";

// Custom components
import { HSeparator } from "components/separator/Separator";
import mifrilLogo from "components/icons/mifril.png";


export function SidebarBrand() {
  //   Chakra color mode
  let logoColor = useColorModeValue("navy.700", "white");

  return (
    <Flex align='center' direction='column'>
      <Image h='75%' w='75%'  src={mifrilLogo} />

      <HSeparator mb='20px' />
    </Flex>
  );
}

export default SidebarBrand;
