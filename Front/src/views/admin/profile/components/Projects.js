// Chakra imports
import { Text, useColorModeValue } from "@chakra-ui/react";
// Assets
import Project1 from "assets/img/profile/Project1.jpg";
import Project2 from "assets/img/profile/Project2.jpg";
import Project3 from "assets/img/profile/Project3.jpg";
import Project4 from "assets/img/profile/Project4.jpg";
// Custom components
import Card from "components/card/Card.js";
import React from "react";
import Project from "views/admin/profile/components/Project";

export default function Projects(props) {
  // Chakra Color Mode
  const textColorPrimary = useColorModeValue("secondaryGray.900", "white");
  const textColorSecondary = "gray.400";
  const cardShadow = useColorModeValue(
    "0px 18px 40px rgba(112, 144, 176, 0.12)",
    "unset"
  );
  return (
    <Card mb={{ base: "0px", "2xl": "20px" }}>
      <Text
        color={textColorPrimary}
        fontWeight='bold'
        fontSize='2xl'
        mt='10px'
        mb='4px'>
        Projects to reduce greenhouse gas emissions
      </Text>
      <Text color={textColorSecondary} fontSize='md' me='26px' mb='40px'>
        Here you can find more details about your projects. Keep your employees
        engaged by providing meaningful information.
      </Text>
      <Project
        boxShadow={cardShadow}
        mb='20px'
        image={Project1}
        ranking='1'
        link='#'
        title='Making the Amazon Rainforest bloom again'
      />
      <Project
        boxShadow={cardShadow}
        mb='20px'
        image={Project2}
        ranking='2'
        link='#'
        title='Johannesburg Hydroelectric Plant'
      />
      <Project
        boxShadow={cardShadow}
        mb='20px'
        image={Project3}
        ranking='3'
        link='#'
        title='France Haute-Normandie Wind Power'
      />
      <Project
        boxShadow={cardShadow}
        mb='20px'
        image={Project4}
        ranking='4'
        link='#'
        title='Maroc Noor Solar panel power plant'
      />
    </Card>
  );
}
