// Chakra imports
import { SimpleGrid,Flex,
  Table,
  Progress,
  Icon,
  Tbody,
  Td,
  Text,
  Th,
  Thead,
  Tr, useColorModeValue } from "@chakra-ui/react";
  import {
    useGlobalFilter,
    usePagination,
    useSortBy,
    useTable,
  } from "react-table";
// Custom components
import Card from "components/card/Card.js";
import React, {useMemo}from "react";
import Information from "views/admin/profile/components/Information";
import IconBox from "components/icons/IconBox";
import {
  MdAddTask,
  MdCloud,
  MdBarChart,
  MdFileCopy,
} from "react-icons/md"


// Assets
import { MdCheckCircle, MdCancel, MdOutlineError } from "react-icons/md";
export default function GeneralInformation(props) {
  const { ...rest} = props;
  // Chakra Color Mode
  const textColorPrimary = useColorModeValue("secondaryGray.900", "white");
  const textColorSecondary = "gray.400";
  const cardShadow = useColorModeValue(
    "0px 18px 40px rgba(112, 144, 176, 0.12)",
    "unset"
  );
  return (
    <Card mb={{ base: "0px", "2xl": "20px" }} {...rest}>
      <Text
        color={textColorPrimary}
        fontWeight='bold'
        fontSize='2xl'
        mt='10px'
        mb='4px'>
        Badge progress
      </Text>
      <Text color={textColorSecondary} fontSize='md' me='26px' mb='40px'>
        Win, earn, and share your MIFRIL path to help get a better planet 
      </Text>
      <SimpleGrid columns='2' gap='20px'>
        <Information
          boxShadow={cardShadow}
          title='Management of Chemicals in Products'
          value='CG-AA-250a.1'
        />
        <IconBox
              w='56px'
              h='56px'
              bg='linear-gradient(90deg, #4481EB 0%, #04BEFE 100%)'
              icon={<Icon w='28px' h='28px' as={MdAddTask} color='white' />}
            />
        <Information
          boxShadow={cardShadow}
          title='Environmental impacts in the Supply Chain'
          value='CG-AA-430a.1'
        />
        <Information
          boxShadow={cardShadow}
          title='Labour Conditions in the Suppy Chain'
          value='CG-AA-430b.2'
        />
        <Information
          boxShadow={cardShadow}
          title='Raw Materials Sourcing'
          value='CG-AA-440a.3'
        />
        <Information
          boxShadow={cardShadow}
          title='Product Safety'
          value='CG-AM-250a.1'
        />
        <Information
          boxShadow={cardShadow}
          title='Product Lifecyle Environnmental Impacts'
          value='CG-AM-410a.1'
        />
      </SimpleGrid>
    </Card>
  );
}
