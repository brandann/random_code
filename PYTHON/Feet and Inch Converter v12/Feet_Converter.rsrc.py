{'application':{'type':'Application',
          'name':'Template',
    'backgrounds': [
    {'type':'Background',
          'name':'bgTemplate',
          'title':u'Standard Template with File->Exit menu',
          'size':(400, 300),
          'backgroundColor':(255, 255, 255),
          'style':['resizeable'],

        'menubar': {'type':'MenuBar',
         'menus': [
             {'type':'Menu',
             'name':'menuFile',
             'label':'&File',
             'items': [
                  {'type':'MenuItem',
                   'name':'menuFileExit',
                   'label':'E&xit',
                   'command':'exit',
                  },
              ]
             },
         ]
     },
         'components': [

{'type':'StaticText', 
    'name':'StaticText3', 
    'position':(260, 84), 
    'text':u'Enter Inches:', 
    },

{'type':'StaticText', 
    'name':'StaticText2', 
    'position':(255, 44), 
    'text':u'Enter Feet:', 
    },

{'type':'TextField', 
    'name':'TextField2', 
    'position':(256, 100), 
    'backgroundColor':(233, 233, 233, 255), 
    },

{'type':'TextField', 
    'name':'TextField1', 
    'position':(254, 61), 
    'backgroundColor':(233, 233, 233, 255), 
    },

{'type':'StaticText', 
    'name':'StaticText1', 
    'position':(12, 69), 
    'text':u'Enter Inches:', 
    },

{'type':'Button', 
    'name':'inchtoarch', 
    'position':(126, 96), 
    'label':u'Inches to Arch Dim', 
    },

{'type':'Button', 
    'name':'archtoinch', 
    'position':(129, 64), 
    'label':u"Arch Dim to Inch's", 
    },

{'type':'TextField', 
    'name':'inch', 
    'position':(12, 86), 
    'backgroundColor':(233, 233, 233, 255), 
    },

] # end components
} # end background
] # end backgrounds
} }
