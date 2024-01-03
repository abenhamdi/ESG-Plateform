// Chakra imports
import { Box, SimpleGrid } from "@chakra-ui/react";
import CheckTable from "views/admin/dataTables/components/CheckTable";
import ComplexTable from "views/admin/dataTables/components/ComplexTable";
import {
  columnsDataCheck,
  columnsDataComplex,
} from "views/admin/dataTables/variables/columnsData";
import tableDataCheck from "views/admin/dataTables/variables/tableDataCheck.json";
import tableDataComplex from "views/admin/dataTables/variables/tableDataComplex.json";
import React from "react";

export default function Settings() {
  // Chakra Color Mode
  return (
    <Box pt={{ base: "130px", md: "80px", xl: "80px" }}>
      <SimpleGrid
        mb='20px'
        columns={{ sm: 1, md: 2 }}
        spacing={{ base: "20px", xl: "20px" }}>
        <CheckTable columnsData={columnsDataCheck} tableData={tableDataCheck} />
        <ComplexTable
          columnsData={columnsDataComplex}
          tableData={tableDataComplex}
        />
      </SimpleGrid>
    </Box>
  );
}
